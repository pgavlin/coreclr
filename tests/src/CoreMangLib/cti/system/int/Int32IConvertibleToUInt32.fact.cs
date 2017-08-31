using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int_Int32IConvertibleToUInt32_Int32IConvertibleToUInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_int_Int32IConvertibleToUInt32_Int32IConvertibleToUInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int\\Int32IConvertibleToUInt32\\Int32IConvertibleToUInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
