using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt161_ConvertToUInt161_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt161_ConvertToUInt161_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt161\\ConvertToUInt161.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
