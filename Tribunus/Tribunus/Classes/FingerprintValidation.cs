using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tribunus.Classes {
    public class FingerprintValidation {
        private CancellationTokenSource _cancel;
        public bool fingerPrintValidate;
        public FingerprintValidation() {
        }
        public async Task<bool> HaveFingerprint() {
            return await CrossFingerprint.Current.IsAvailableAsync(true);
        }

        public async Task AuthenticationAsync(string reason, bool abortRead, string cancel = null, string fallback = null, string tooFast = null) {
            _cancel = abortRead ? new CancellationTokenSource(TimeSpan.FromSeconds(10)) : new CancellationTokenSource();
            var dialogConfig = new AuthenticationRequestConfiguration(reason) {
                CancelTitle = cancel,
                FallbackTitle = fallback,
                UseDialog = true
            };
            var result = await Plugin.Fingerprint.CrossFingerprint.Current.AuthenticateAsync(dialogConfig, _cancel.Token);
            SetResultAsync(result);
        }

        public void SetResultAsync(FingerprintAuthenticationResult result) {
            if (result.Authenticated) {
                fingerPrintValidate = true;
            }
            else {
                fingerPrintValidate = false;
            }
        }
    }
}
