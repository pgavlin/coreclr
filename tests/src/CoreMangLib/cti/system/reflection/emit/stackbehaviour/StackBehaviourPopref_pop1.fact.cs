using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_stackbehaviour_StackBehaviourPopref_pop1_StackBehaviourPopref_pop1_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_stackbehaviour_StackBehaviourPopref_pop1_StackBehaviourPopref_pop1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\stackbehaviour\\StackBehaviourPopref_pop1\\StackBehaviourPopref_pop1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
