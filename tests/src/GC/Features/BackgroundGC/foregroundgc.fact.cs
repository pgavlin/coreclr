using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _BackgroundGC_foregroundgc_foregroundgc_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _BackgroundGC_foregroundgc_foregroundgc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\BackgroundGC\\foregroundgc\\foregroundgc.cmd");
        }
    }
}
