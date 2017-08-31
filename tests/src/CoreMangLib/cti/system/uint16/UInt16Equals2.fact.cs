using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16Equals2_UInt16Equals2_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16Equals2_UInt16Equals2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16Equals2\\UInt16Equals2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
