using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_verify_verify01_dynamic_verify01_dynamic_
    {
        [ActiveIssue("4851")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _localloc_verify_verify01_dynamic_verify01_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\verify\\verify01_dynamic\\verify01_dynamic.cmd");
        }
    }
}
