using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt329_ConvertToUInt329_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt329_ConvertToUInt329_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt329\\ConvertToUInt329.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
