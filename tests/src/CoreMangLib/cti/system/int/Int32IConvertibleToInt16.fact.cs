using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int_Int32IConvertibleToInt16_Int32IConvertibleToInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_int_Int32IConvertibleToInt16_Int32IConvertibleToInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int\\Int32IConvertibleToInt16\\Int32IConvertibleToInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
