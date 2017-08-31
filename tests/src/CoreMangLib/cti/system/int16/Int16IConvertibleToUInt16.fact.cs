using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int16_Int16IConvertibleToUInt16_Int16IConvertibleToUInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_int16_Int16IConvertibleToUInt16_Int16IConvertibleToUInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int16\\Int16IConvertibleToUInt16\\Int16IConvertibleToUInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
