using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16Equals1_UInt16Equals1_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16Equals1_UInt16Equals1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16Equals1\\UInt16Equals1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
