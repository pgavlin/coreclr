using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_structlayoutattribute_StructLayoutAttributeSize_StructLayoutAttributeSize_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_structlayoutattribute_StructLayoutAttributeSize_StructLayoutAttributeSize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\structlayoutattribute\\StructLayoutAttributeSize\\StructLayoutAttributeSize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
