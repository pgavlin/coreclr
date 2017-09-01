using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_funclet_funclet_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _gc_misc_funclet_funclet_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\funclet\\funclet.cmd");
        }
    }
}
