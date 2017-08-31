using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int_Int32IConvertibleToInt32_Int32IConvertibleToInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_int_Int32IConvertibleToInt32_Int32IConvertibleToInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int\\Int32IConvertibleToInt32\\Int32IConvertibleToInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
