using CoreclrTestLib;
using Xunit;

namespace JIT_superpmi
{
    class _superpmicollect_superpmicollect_
    {
        [Trait("ExcludeBuiltAgainstPackages", "*")]
        [Trait("ExcludeILLink", "{illinkExclude}")]
        [Fact]
        public void _superpmicollect_superpmicollect_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\superpmi\\superpmicollect\\superpmicollect.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
