using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt645_ConvertToUInt645_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt645_ConvertToUInt645_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt645\\ConvertToUInt645.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
