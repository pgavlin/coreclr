using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _threadpool_unregister_unregister03_unregister03_
    {
        [OuterLoop]
        [Fact]
        public void _threadpool_unregister_unregister03_unregister03_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\unregister\\unregister03\\unregister03.cmd");
        }
    }
}
