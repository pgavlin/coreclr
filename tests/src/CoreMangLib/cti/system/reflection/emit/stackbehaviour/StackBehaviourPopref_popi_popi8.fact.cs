using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_stackbehaviour_StackBehaviourPopref_popi_popi8_StackBehaviourPopref_popi_popi8_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_stackbehaviour_StackBehaviourPopref_popi_popi8_StackBehaviourPopref_popi_popi8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\stackbehaviour\\StackBehaviourPopref_popi_popi8\\StackBehaviourPopref_popi_popi8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
