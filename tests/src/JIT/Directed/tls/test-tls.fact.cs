using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _tls_test_tls_test_tls_
    {
        [ActiveIssue("2441")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _tls_test_tls_test_tls_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\tls\\test-tls\\test-tls.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
