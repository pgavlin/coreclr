using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int_Int32IConvertibleToUInt16_Int32IConvertibleToUInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_int_Int32IConvertibleToUInt16_Int32IConvertibleToUInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int\\Int32IConvertibleToUInt16\\Int32IConvertibleToUInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
