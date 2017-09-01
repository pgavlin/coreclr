using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _tls_test_tls_test_tls_
    {
        [ActiveIssue("2441")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _tls_test_tls_test_tls_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\tls\\test-tls\\test-tls.cmd");
        }
    }
}
