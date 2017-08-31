using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int16_Int16IConvertibleToType_Int16IConvertibleToType_
    {
        [OuterLoop]
        [Fact]
        public void _system_int16_Int16IConvertibleToType_Int16IConvertibleToType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int16\\Int16IConvertibleToType\\Int16IConvertibleToType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
