using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodes_OpCodeStackBehaviourPush_OpCodeStackBehaviourPush_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodes_OpCodeStackBehaviourPush_OpCodeStackBehaviourPush_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodes\\OpCodeStackBehaviourPush\\OpCodeStackBehaviourPush.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
