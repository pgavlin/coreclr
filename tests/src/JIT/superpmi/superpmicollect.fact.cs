using CoreclrTestLib;
using Xunit;

namespace JIT_superpmi
{
    public class _superpmicollect_superpmicollect_
    {
        [Trait("ExcludeBuiltAgainstPackages", "*")]
        [Trait("ExcludeILLink", "{illinkExclude}")]
        [Fact]
        public void _superpmicollect_superpmicollect_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\superpmi\\superpmicollect\\superpmicollect.cmd");
        }
    }
}
