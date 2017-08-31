using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt164_ConvertToUInt164_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt164_ConvertToUInt164_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt164\\ConvertToUInt164.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
