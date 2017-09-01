using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _generics_Monitor_EnterExit02_EnterExit02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_EnterExit02_EnterExit02_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\EnterExit02\\EnterExit02.cmd");
        }
    }
}
