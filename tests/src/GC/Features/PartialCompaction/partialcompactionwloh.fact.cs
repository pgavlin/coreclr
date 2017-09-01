using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _PartialCompaction_partialcompactionwloh_partialcompactionwloh_
    {
        [OuterLoop]
        [Fact]
        public void _PartialCompaction_partialcompactionwloh_partialcompactionwloh_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\PartialCompaction\\partialcompactionwloh\\partialcompactionwloh.cmd");
        }
    }
}
