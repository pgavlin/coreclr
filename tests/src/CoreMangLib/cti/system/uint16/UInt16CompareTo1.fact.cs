using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16CompareTo1_UInt16CompareTo1_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16CompareTo1_UInt16CompareTo1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16CompareTo1\\UInt16CompareTo1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
