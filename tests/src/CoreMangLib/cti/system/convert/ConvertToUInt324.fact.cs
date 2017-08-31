using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt324_ConvertToUInt324_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt324_ConvertToUInt324_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt324\\ConvertToUInt324.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
