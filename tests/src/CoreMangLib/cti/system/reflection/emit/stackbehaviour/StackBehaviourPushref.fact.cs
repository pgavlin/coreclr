using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_stackbehaviour_StackBehaviourPushref_StackBehaviourPushref_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_stackbehaviour_StackBehaviourPushref_StackBehaviourPushref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\stackbehaviour\\StackBehaviourPushref\\StackBehaviourPushref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
