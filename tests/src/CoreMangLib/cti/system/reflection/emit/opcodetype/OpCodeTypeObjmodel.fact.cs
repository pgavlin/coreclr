using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodetype_OpCodeTypeObjmodel_OpCodeTypeObjmodel_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodetype_OpCodeTypeObjmodel_OpCodeTypeObjmodel_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodetype\\OpCodeTypeObjmodel\\OpCodeTypeObjmodel.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
