using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_sbyte_SByteMaxValue_SByteMaxValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_sbyte_SByteMaxValue_SByteMaxValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\sbyte\\SByteMaxValue\\SByteMaxValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
