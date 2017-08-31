using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt3218_ConvertToUInt3218_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt3218_ConvertToUInt3218_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt3218\\ConvertToUInt3218.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
