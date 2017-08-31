using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt328_ConvertToUInt328_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt328_ConvertToUInt328_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt328\\ConvertToUInt328.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
