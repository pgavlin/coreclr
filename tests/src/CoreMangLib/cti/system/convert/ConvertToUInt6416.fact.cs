using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt6416_ConvertToUInt6416_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt6416_ConvertToUInt6416_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt6416\\ConvertToUInt6416.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
