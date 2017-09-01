using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_verify_verify01_large_verify01_large_
    {
        [ActiveIssue("4851")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _localloc_verify_verify01_large_verify01_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\verify\\verify01_large\\verify01_large.cmd");
        }
    }
}
