using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_dev10_bug679008_singleRefField_singleRefField_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug679008_singleRefField_singleRefField_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679008\\singleRefField\\singleRefField.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
