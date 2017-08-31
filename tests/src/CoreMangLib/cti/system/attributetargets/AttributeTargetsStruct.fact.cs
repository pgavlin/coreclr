using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsStruct_AttributeTargetsStruct_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsStruct_AttributeTargetsStruct_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsStruct\\AttributeTargetsStruct.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
