using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _PartialCompaction_partialcompactiontest_partialcompactiontest_
    {
        [OuterLoop]
        [Fact]
        public void _PartialCompaction_partialcompactiontest_partialcompactiontest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\PartialCompaction\\partialcompactiontest\\partialcompactiontest.cmd");
        }
    }
}
