using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_structlayoutattribute_StructLayoutAttributePack_StructLayoutAttributePack_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_structlayoutattribute_StructLayoutAttributePack_StructLayoutAttributePack_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\structlayoutattribute\\StructLayoutAttributePack\\StructLayoutAttributePack.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
