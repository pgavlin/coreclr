using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _generics_Monitor_EnterExit01_EnterExit01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_EnterExit01_EnterExit01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\EnterExit01\\EnterExit01.cmd");
        }
    }
}
