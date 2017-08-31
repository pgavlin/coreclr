using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_single_SingleToSByte_SingleToSByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleToSByte_SingleToSByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleToSByte\\SingleToSByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
