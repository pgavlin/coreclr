using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_dev10_bug679008_singleRefField_singleRefField_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug679008_singleRefField_singleRefField_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679008\\singleRefField\\singleRefField.cmd");
        }
    }
}
