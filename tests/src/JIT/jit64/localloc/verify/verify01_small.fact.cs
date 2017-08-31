using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_verify_verify01_small_verify01_small_
    {
        [ActiveIssue("4851")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _localloc_verify_verify01_small_verify01_small_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\verify\\verify01_small\\verify01_small.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
