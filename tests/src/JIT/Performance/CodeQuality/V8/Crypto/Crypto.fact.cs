using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_V8_Crypto_Crypto_Crypto_
    {
        [Fact]
        public void _CodeQuality_V8_Crypto_Crypto_Crypto_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\V8\\Crypto\\Crypto\\Crypto.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
