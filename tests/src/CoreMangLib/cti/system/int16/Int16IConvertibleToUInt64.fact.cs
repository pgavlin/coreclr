using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int16_Int16IConvertibleToUInt64_Int16IConvertibleToUInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_int16_Int16IConvertibleToUInt64_Int16IConvertibleToUInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int16\\Int16IConvertibleToUInt64\\Int16IConvertibleToUInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
