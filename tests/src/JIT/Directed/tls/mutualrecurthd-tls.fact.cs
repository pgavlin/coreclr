using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _tls_mutualrecurthd_tls_mutualrecurthd_tls_
    {
        [ActiveIssue("2441")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _tls_mutualrecurthd_tls_mutualrecurthd_tls_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\tls\\mutualrecurthd-tls\\mutualrecurthd-tls.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
