using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _tls_mutualrecurthd_tls_mutualrecurthd_tls_
    {
        [ActiveIssue("2441")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _tls_mutualrecurthd_tls_mutualrecurthd_tls_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\tls\\mutualrecurthd-tls\\mutualrecurthd-tls.cmd");
        }
    }
}
