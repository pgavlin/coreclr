using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _struct16args_struct16args_
    {
        [OuterLoop]
        [Fact]
        public void _struct16args_struct16args_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\struct16args\\struct16args.cmd");
        }
    }
}
