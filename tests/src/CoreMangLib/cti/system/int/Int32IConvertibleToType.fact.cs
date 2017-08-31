using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int_Int32IConvertibleToType_Int32IConvertibleToType_
    {
        [OuterLoop]
        [Fact]
        public void _system_int_Int32IConvertibleToType_Int32IConvertibleToType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int\\Int32IConvertibleToType\\Int32IConvertibleToType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
