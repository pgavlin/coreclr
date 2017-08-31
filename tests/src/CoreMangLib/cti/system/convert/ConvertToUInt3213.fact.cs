using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt3213_ConvertToUInt3213_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt3213_ConvertToUInt3213_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt3213\\ConvertToUInt3213.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
