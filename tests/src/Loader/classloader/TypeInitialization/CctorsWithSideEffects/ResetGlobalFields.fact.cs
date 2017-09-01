using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _TypeInitialization_CctorsWithSideEffects_ResetGlobalFields_ResetGlobalFields_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_CctorsWithSideEffects_ResetGlobalFields_ResetGlobalFields_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CctorsWithSideEffects\\ResetGlobalFields\\ResetGlobalFields.cmd");
        }
    }
}
