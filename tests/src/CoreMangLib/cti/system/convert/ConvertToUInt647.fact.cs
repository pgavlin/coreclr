using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt647_ConvertToUInt647_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt647_ConvertToUInt647_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt647\\ConvertToUInt647.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
