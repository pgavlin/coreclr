using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt3219_ConvertToUInt3219_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt3219_ConvertToUInt3219_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt3219\\ConvertToUInt3219.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
