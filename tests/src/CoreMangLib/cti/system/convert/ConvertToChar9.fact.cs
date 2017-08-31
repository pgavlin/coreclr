using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToChar9_ConvertToChar9_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToChar9_ConvertToChar9_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToChar9\\ConvertToChar9.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
