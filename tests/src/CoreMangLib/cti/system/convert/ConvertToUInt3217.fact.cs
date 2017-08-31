using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt3217_ConvertToUInt3217_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt3217_ConvertToUInt3217_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt3217\\ConvertToUInt3217.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
