using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int16_Int16IConvertibleToUInt32_Int16IConvertibleToUInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_int16_Int16IConvertibleToUInt32_Int16IConvertibleToUInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int16\\Int16IConvertibleToUInt32\\Int16IConvertibleToUInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
