using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt648_ConvertToUInt648_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt648_ConvertToUInt648_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt648\\ConvertToUInt648.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
