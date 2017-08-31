using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_enum_EnumToObjectb_EnumToObjectb_
    {
        [OuterLoop]
        [Fact]
        public void _system_enum_EnumToObjectb_EnumToObjectb_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\enum\\EnumToObjectb\\EnumToObjectb.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
