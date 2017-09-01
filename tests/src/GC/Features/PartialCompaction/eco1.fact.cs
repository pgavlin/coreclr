using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _PartialCompaction_eco1_eco1_
    {
        [OuterLoop]
        [Fact]
        public void _PartialCompaction_eco1_eco1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\PartialCompaction\\eco1\\eco1.cmd");
        }
    }
}
